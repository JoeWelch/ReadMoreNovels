import { useCallback, useState } from "react";
import { Form, Image, Input } from "semantic-ui-react";
import { formatPublishDate } from "../../utils/String";

import "./search.css";
import { useSearch } from "../../hooks/mutations/Search";

const BOOK = {
  id: 123456,
  title: "How to Change Your Mind",
  author: "Michael Pollan",
  publisher: "Penguin Press",
  publishedDate: new Date(),
  description:
    'How to Change Your Mind chronicles the long and storied history of psychedelic drugs, from their turbulent 1960s heyday to the resulting counter culture movement and backlash. Through his coverage of the recent resurgence in this field of research, as well as his own personal use of psychedelics via a "mental travelogue", Pollan seeks to illuminate not only the mechanics of the drugs themselves, but also the inner workings of the human mind and consciousness.',
  pageCount: 480,
  genre: "non-fiction",
  language: "english",
  ISBN_13: "978-1-59420-422-7",
  ISBN_10: "978-1-59420-7",
  thumbnail:
    "https://upload.wikimedia.org/wikipedia/en/a/a2/How_to_change_your_mind_pollan.jpg",
};

const Search = () => {
  const [searchTerm, setSearchTerm] = useState("");
  // const [searchResults, setSearchResults] = useState([BOOK]);
  const mutation = useSearch();

  const handleSearchChange = useCallback((input) => {
    setSearchTerm(input);
  }, []);

  const handleSearchSubmit = useCallback(() => {
    if (searchTerm.length > 0) {
      mutation.mutate(searchTerm);
    }
  }, [mutation, searchTerm]);

  return (
    <div className="search-container">
      <Form onSubmit={handleSearchSubmit}>
        <h2>Search</h2>
        <Input
          placeholder="title, author, genre, etc..."
          value={searchTerm}
          onChange={(e) => handleSearchChange(e.target.value)}
          className="search-input"
        />
      </Form>
      <div className="search-results-container">
        <div className="search-result">
          <div className="search-result-top-row">
            <div className="search-result-image-container">
              <Image src={BOOK.thumbnail} size={"large"} />
            </div>
            <div className="search-result-info-container">
              <h1 className="search-result-title">{BOOK.title}</h1>
              <h2 className="search-result-author">{BOOK.author}</h2>
              <p className="search-result-description">{BOOK.description}</p>
            </div>
          </div>
          <div className="search-result-details">
            <p>{`${BOOK.genre}, ${BOOK.language}`}</p>
            {`${BOOK.publisher}, ${formatPublishDate(BOOK.publishedDate)}, ${
              BOOK.pageCount
            } pages`}
            <p>{BOOK.ISBN_13}</p>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Search;
