import "semantic-ui-css/semantic.min.css";
import SearchPage from "./Components/Pages/SearchPage";
import { Header } from "semantic-ui-react";

function App() {
  return (
    <>
      <Header as='h1' content="Read More Novels" textAlign='center' />
      <SearchPage />
    </>
  );
}

export default App;
