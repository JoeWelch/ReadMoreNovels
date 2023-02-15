// import './App.css';
import * as mock from './MockFunctions';
import React, {useState} from 'react';

function App() {
  const [userId, setUserId] = useState(0);

  const NoUser = () => 
  {
    return (
        <button onClick={()=> {var x = mock.loginUser('joewelch@msn.com', 'Joe Welch'); setUserId(x.UserId);}}>Login User</button>
    )

  };

  const LoggedInUser = () => 
  {
    return (
      <div>
        <p>User Logged In</p>
        <button onClick={()=> {var x = mock.logoutUser(); setUserId(0);}}>Logout User</button>
      </div>
    );
  }
  
  return (
    <div>
      {((userId === 0) && <NoUser/>)}
      {((userId != 0) && <LoggedInUser/>)}
      </div>
  );
}

export default App;
