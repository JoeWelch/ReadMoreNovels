import 'semantic-ui-css/semantic.min.css'
import SearchPage from './Components/Pages/SearchPage';
import { Header } from 'semantic-ui-react';

function App() {
  return (
    <div className="App">
      <Header as='h1' content="Read More Novels" textAlign='center' />
      {/* <h2>{process.env.REACT_APP_SAMPLE_VAR}</h2> */}
      <SearchPage />
    </div>
  );
}

export default App;
