import axios from "axios";
import { BOOK_SERVICE_API } from "../constants/services";

export const postSearch = (searchTerm) => {
  return axios.post(`${BOOK_SERVICE_API}/search`, { query: searchTerm });
};
