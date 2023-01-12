import { React, useState, useEffect } from 'react';
import '../App.css';
import { apiCall } from '../Services/apiCall';
import DataGrid, { TextEditor } from 'react-data-grid';


export default function BooksLoggedOut() {
    const [titleSearch, setTitleSearch] = useState('Happiness');
    const [formattedtitleSearch, setFormattedTitleSearch] = useState('');
    const [results, setResults] = useState([]);

    useEffect(() => {
        handleSubmit();
    }, []);

    const handleChange = (event) => {
        setTitleSearch(event.target.value);
    }

    async function handleSubmit() {
        let formattedSearch = titleSearch.replaceAll(' ', '+');
        setFormattedTitleSearch(formattedSearch);
        try {
            var api = new apiCall();
            const data = await api.searchBooks(formattedSearch);
            setResults(data);
        }
        catch (e) {
            console.log(e);
        }
    }

    const columns = [
        { key: 'worksKey', name: 'Works Key', width: 100 },
        {
            key: 'title', name: 'Title',
            formatter(props) {
                return <><button className="btn btn-link" onClick={() => window.location = `/bookdetail/${props.row.worksKey}`}> {props.row.title} </button></>
            }
        },
        { key: 'author', name: 'Author' },
    ];

    return (
        <div className="App-header">
            <div className="App-grids">
                <p> Welcome to Books </p>
                <form>
                    <label>
                        Book Title:
                        <input type="text" value={titleSearch} onChange={handleChange} />
                    </label>
                </form>
                <button onClick={handleSubmit}> Search </button>
                <p>
                    <DataGrid columns={columns} rows={results} />

                    {/*  {results.map(x => (
                    <div className="App-header">                       
                        <img src={x.coverURL} />
                        <p> {String(x.title)} </p>
                        <p> {String(x.author)} </p>
                        <p> {String(x.worksKey)} </p>
                        <button onClick={() => window.location = `/bookdetail/${x.worksKey}` }> Read More </button>
                    </div>                    
                    ))}  */ }
                </p>
            </div>
        </div>
    );
}
