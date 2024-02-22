import { Image } from "semantic-ui-react";
import PropTypes from "prop-types";
import { formatPublishDate } from "../../../../utils/String";

import "../styles/search-result.css";

const SearchResult = ({ result }) => {
  return (
    <div className="search-result">
      <div className="search-result-image-container">
        <Image src={result.thumbnail} size={"large"} />
      </div>
      <div className="search-result-info-container">
        <h3 className="search-result-title">{result.title}</h3>
        <h4 className="search-result-author">
          <em>{result.author}</em>
        </h4>
        <p className="search-result-description">{result.description}</p>
        <div className="search-result-details">
          <div className="detail">{`${result.publisher}, ${formatPublishDate(
            result.publishedDate
          )}`}</div>
          <div className="detail">{`${result.genre}, ${result.language}`}</div>
          <div className="detail">{`${result.pageCount} pages`}</div>
          <div className="detail">{result.ISBN_13}</div>
        </div>
      </div>
    </div>
  );
};

SearchResult.propTypes = {
  result: PropTypes.object,
};

export default SearchResult;
