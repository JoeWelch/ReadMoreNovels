import './App.css';
import { GoogleLogin, GoogleLogout } from 'react-google-login';
import 'bootstrap/dist/css/bootstrap.min.css';
import { React, useState } from 'react';
import LoggedOut from './components/LoggedOut'
import { Navbar, Nav, Container } from 'react-bootstrap'
import About from './components/About'
import Books from './components/Books'
import BooksLoggedOut from './components/BooksLoggedOut'
import Home from './components/Home'
import BookDetail from './components/BookDetail'
import MyBooks from './components/MyBooks'
import BookDetailLoggedOut from './components/BookDetailLoggedOut'
import {
    BrowserRouter as Router,
    Route,
    Routes,
    NavLink
} from 'react-router-dom'
import { apiCall } from './Services/apiCall';




function App() {
    const [loggedIn, setLoggedIn] = useState(false);
    const [userName, setuserName] = useState('');
    const [userNameAPI, setuserNameAPI] = useState('');
    const [userEmail, setuserEmail] = useState('');



    async function successfulLogin(response) {
        console.log(response);
        setLoggedIn(true);
        setuserName(response.profileObj.givenName);
        setuserEmail(response.profileObj.email);
        var user = new apiCall();
        const data = await user.searchUsers(response.profileObj.email);


        if (data.emailAddress) {
            setuserNameAPI(data.name)
        }
        /*
                else {
                    apiCall.createUser(response.profileObj.givenName, response.profileObj.email)
                } */
    };


    const successfulLogout = (response) => {
        setLoggedIn(false);
        setuserName('');
        setuserEmail('');
    }

    const responseGoogle = (response) => {
        console.log(response);
    }

    return (
        <div>
            <div> {(loggedIn) ?
                <div>
                    <Router>
                        <Navbar collapseOnSelect expand="lg" bg="light" variant="light">
                            <Container>
                                <Navbar.Brand href="/">Read More Novels</Navbar.Brand>
                                <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                                <Navbar.Collapse id="responsive-navbar-nav">
                                    <Nav className="me-auto">
                                        <Nav.Link> <NavLink to="/" style={({ isActive }) => isActive ? { color: 'dimgray', fontWeight: '500', textDecoration: 'none' } : { color: 'gray', textDecoration: 'none' }}> Home </NavLink > </Nav.Link>
                                        <Nav.Link> <NavLink to="/about" style={({ isActive }) => isActive ? { color: 'dimgray', fontWeight: '500', textDecoration: 'none' } : { color: 'gray', textDecoration: 'none' }}> About </NavLink > </Nav.Link>
                                        <Nav.Link> <NavLink to="/books" style={({ isActive }) => isActive ? { color: 'dimgray', fontWeight: '500', textDecoration: 'none' } : { color: 'gray', textDecoration: 'none' }}> Books </NavLink > </Nav.Link>
                                        <Nav.Link> <NavLink to="/my-books" style={({ isActive }) => isActive ? { color: 'dimgray', fontWeight: '500', textDecoration: 'none' } : { color: 'gray', textDecoration: 'none' }}> My Books </NavLink > </Nav.Link>
                                    </Nav>
                                    <Nav>
                                        <Navbar.Text className='WelcomeText'> Welcome, {userName}! </Navbar.Text>
                                        {/*<Navbar.Text className='WelcomeText'> Welcome, {userNameAPI}! </Navbar.Text> */}
                                        <GoogleLogout
                                            clientId="900333464193-8pq8jl4cfe16t7g1nb080aiagg3lova1.apps.googleusercontent.com"
                                            buttonText="Logout"
                                            onFailure={responseGoogle}
                                            onLogoutSuccess={successfulLogout}>
                                        </GoogleLogout>
                                    </Nav>
                                </Navbar.Collapse>
                            </Container>
                        </Navbar>
                        <Routes>
                            <Route path="/" index element={<Home />}></Route>
                            <Route path="/about" element={<About />}></Route>
                            <Route path="/books" element={<Books />}></Route>
                            <Route path="/my-books" element={<MyBooks />}></Route>
                            <Route path="/bookdetail/:id" element={<BookDetail />}></Route>
                        </Routes>
                    </Router>
                </div>

                :

                <div>
                    <Navbar bg="light" variant="light">
                        <Container>
                            <Navbar.Brand href="/">Book App</Navbar.Brand>
                            <Nav className="me-auto">
                                <Nav.Link href="/">Home</Nav.Link>
                            </Nav>
                            <Nav>
                                <GoogleLogin
                                    clientId="900333464193-8pq8jl4cfe16t7g1nb080aiagg3lova1.apps.googleusercontent.com"
                                    buttonText="Login"
                                    onSuccess={successfulLogin}
                                    onFailure={responseGoogle}
                                    isSignedIn={true}>
                                </GoogleLogin>
                            </Nav>
                        </Container>
                    </Navbar>
                    <LoggedOut></LoggedOut>
                </div>}
            </div>
        </div>
    );
}

export default App;