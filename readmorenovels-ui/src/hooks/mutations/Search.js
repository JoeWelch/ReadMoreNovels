import { useMutation } from "@tanstack/react-query";
import { postSearch } from "../../api/search";

export const useSearch = ({ setSearchResults }) => {
  const mutation = useMutation({
    mutationFn: (searchTerm) => postSearch(searchTerm),
    onSuccess: ({ data }) => {
      setSearchResults(data);
    },
  });
  return mutation;
};
