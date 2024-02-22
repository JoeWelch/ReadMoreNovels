import "semantic-ui-css/semantic.min.css";
import { Header } from "semantic-ui-react";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import { ReactQueryDevtools } from "@tanstack/react-query-devtools";
import { Search } from "./Components/Organisms";
import { version } from "./constants/version";
import "./app.css";

function App() {
  const queryClient = new QueryClient();

  return (
    <>
      <QueryClientProvider client={queryClient}>
        <ReactQueryDevtools initialIsOpen={false} />
        <div className="app-header"></div>
        <Header as="h1" content="Read More Novels" textAlign="center" />
        <div className="app-body">
          <Search />
        </div>
        <div className="app-footer">
          <span>version {version}</span>
        </div>
      </QueryClientProvider>
    </>
  );
}

export default App;
