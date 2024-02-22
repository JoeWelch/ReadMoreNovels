import PropTypes from 'prop-types';

const SearchResult = (props) => {
  const { title } = props;
  return <div>{title}</div>;
};

SearchResult.propTypes = {
    title: PropTypes.string,
}

export default SearchResult;
