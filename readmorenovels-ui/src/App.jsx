import "semantic-ui-css/semantic.min.css";
// import SearchPage from "./Components/Pages/SearchPage";
import { Header } from "semantic-ui-react";
import Search from "./Components/Organisms/Search";

function App() {
  return (
    <>
      <Header as='h1' content="Read More Novels" textAlign='center' />
      {/* <SearchPage /> */}
      <Search />
    </>
  );
}

export default App;
