import "semantic-ui-css/semantic.min.css";
// import SearchPage from "./Components/Pages/SearchPage";
import { Header } from "semantic-ui-react";
import Search from "./Components/Organisms/Search";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";

function App() {
  const queryClient = new QueryClient();

  return (
    <>
      <QueryClientProvider client={queryClient}>
        <Header as="h1" content="Read More Novels" textAlign="center" />
        {/* <SearchPage /> */}
        <Search />
      </QueryClientProvider>
    </>
  );
}

export default App;
