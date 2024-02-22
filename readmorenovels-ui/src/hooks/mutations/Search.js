import { useMutation } from "@tanstack/react-query";
import { postSearch } from "../../api/search";

export const useSearch = () => {
  const mutation = useMutation({
    mutationFn: (searchTerm) => postSearch(searchTerm),
  });
  return mutation;
};
