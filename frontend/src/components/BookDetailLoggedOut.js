import '../App.css';
import { React, useState, useEffect } from 'react';
import { apiCall } from '../Services/apiCall';


function BookDetailLoggedOut() {
    //TODO: Create compound object to reduce the number of hooks needed here, just store all Book fields in one book object using a single hook to update fields
    const [bookTitle, setBookTitle] = useState('');
    const [bookAuthor, setBookAuthor] = useState('');
    const [bookDescription, setBookDescription] = useState('');
    const [bookSubjects, setBookSubjects] = useState('');
    const [bookYearPublished, setBookYearPublished] = useState('');

    const urlList = window.location.href.split("/")
    const workskey = urlList[urlList.length - 1]
    const coverURL = "https://covers.openlibrary.org/w/olid/" + workskey + "-M.jpg"

    async function bookinfo(workskey) {
        var api = new apiCall();
        const data = await api.searchBook(workskey);

        setBookTitle(data[0].title);
        setBookAuthor(data[0].authorName);
        setBookDescription(data[0].description);
        setBookSubjects(data[0].subjects);
        setBookYearPublished(data[0].yearFirstPublished);
    }

    useEffect(() => {
        bookinfo(workskey);
    }, []);

    return (
        <div className="App-details">
            <img src={coverURL} />
            <br></br>
            <h3> {bookTitle} </h3>
            <br></br>
            <p> By Author: {String(bookAuthor)} </p>
            <p> Year Published: {bookYearPublished} </p>
            <p> Subjects: {String(bookSubjects)} </p>
            <br></br>
            <p> <i> Description: {bookDescription} </i> </p>
        </div>
    );
}

export default BookDetailLoggedOut;

//Sources:
//https://reactgo.com/fetch-data-react-hooks/
