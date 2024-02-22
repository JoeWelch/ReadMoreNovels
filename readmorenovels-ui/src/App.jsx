import "semantic-ui-css/semantic.min.css";
import { Header } from "semantic-ui-react";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import { ReactQueryDevtools } from "@tanstack/react-query-devtools";
import "./app.css";
import { Search } from "./Components/Organisms";

function App() {
  const queryClient = new QueryClient();

  return (
    <>
      <QueryClientProvider client={queryClient}>
        <ReactQueryDevtools initialIsOpen={false} />
        <Header as="h1" content="Read More Novels" textAlign="center" />
        <div className="app-container">
          <Search />
        </div>
      </QueryClientProvider>
    </>
  );
}

export default App;
