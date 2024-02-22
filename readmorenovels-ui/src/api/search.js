import axios from "axios";

export const postSearch = async (searchTerm) => {
  await axios.post("/search", { term: searchTerm });
};
