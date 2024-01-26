import './App.css';

function App() {
  return (
    <div className="App">
      <h1>Read More Novels</h1>
      <h2>{process.env.REACT_APP_SAMPLE_VAR}</h2>
    </div>
  );
}

export default App;
