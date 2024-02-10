import React from "react";
import {
  Accordion,
  Container,
  Grid,
  GridColumn,
  Header,
  Search,
} from "semantic-ui-react";

import "./searchPage.css";

const BOOKS = [
  { title: "Neuromancer", content: "Cyberpunk novel by William Gibson" },
  { title: "The Hobbit", content: "Fantasy novel by J.R.R. Tolkien" },
  { title: "The Great Gatsby", content: "Novel by F. Scott Fitzgerald" },
  { title: "The Catcher in the Rye", content: "Novel by J. D Salinger" },
  { title: "House of Leaves", content: "Horror novel by Mark Z. Danielewski" },
  { title: "The Shining", content: "Horror novel by Stephen King" },
  { title: "Anna Karenina", content: "Novel by Leo Tolstoy" },
  { title: "Dune", content: "Science fiction novel by Frank Herbert" },
];

const SearchPage = () => {
  return (
    <Container text>
      <Header as="h2" content="Search" textAlign="center" />
      <Grid centered>
        <GridColumn width={10}>
          <Search
            placeholder="title, author, genre, etc..."
          />
          <Accordion
            styled
            defaultActiveIndex={[]}
            exclusive={false}
            panels={BOOKS.map((book, i) => {
              return {
                key: i,
                title: book.title,
                content: { content: <p>{book.content}</p> },
              };
            })}
          />
        </GridColumn>
      </Grid>
    </Container>
  );
};

const SearchResult = () => {};

export default SearchPage;
