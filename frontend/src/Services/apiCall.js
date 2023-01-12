
export class apiCall {
    constructor() { }

    async genericGet(url) {
        return fetch(url, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error("HTTP error, status = " + response.status);
                }
                return response.json();
            })
            .then(json => { return json; })
    }


    async genericPost(url, body, methodName = 'POST') {
        return fetch(url, {
            method: methodName,
            body: JSON.stringify(body),
            headers: {
                'Content-Type': 'application/json'
            }
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error("HTTP error, status = " + response.status);
                }
                return response.json();
            })
            .then(json => { return json; })
    }

    async searchBooks(formattedSearch) {
        //const url = process.env.REACT_APP_ENDPOINT + `/api/Books/search/ol/${formattedSearch}`;
        const url = 'https://bookapp-api-function-alysha.azurewebsites.net' + `/api/Books/search/${formattedSearch}`;
        return this.genericGet(url);
    }

    async searchBook(workskey) {
        //const url = process.env.REACT_APP_ENDPOINT + `/api/Books/search/ol/key/${workskey}`;
        const url = 'https://bookapp-api-function-alysha.azurewebsites.net' + `/api/Books/search/key/${workskey}`;
        return this.genericGet(url);
    }

    async searchAuthors(formattedSearch) {
        //const url = process.env.REACT_APP_ENDPOINT + `/api/Authors/search/ol/${formattedSearch}`;
        const url = 'https://bookapp-api-function-alysha.azurewebsites.net' + `/api/Authors/search/${formattedSearch}`;
        return this.genericGet(url);
    }

    async searchAuthor(authorkey) {
        //const url = process.env.REACT_APP_ENDPOINT + `/api/Authors/search/ol/key/${authorkey}`;
        const url = 'https://bookapp-api-function-alysha.azurewebsites.net' + `/api/Authors/search/key/${authorkey}`;
        return this.genericGet(url);
    }

    async searchUsers(emailAddress) {
        //const url = process.env.REACT_APP_ENDPOINT + `/api/UserProfiles/email/${emailAddress}`;
        const urlPrefix = process.env.REACT_APP_ENDPOINT;
        console.log(emailAddress);
        console.log(urlPrefix);
        const url = 'https://bookapp-api-function-alysha.azurewebsites.net' + `/api/UserProfiles/email/${emailAddress}`;
        return this.genericGet(url);
    }

    async searchErrors() {
        //const url = process.env.REACT_APP_ENDPOINT + `/api/Authors/search/ol/key/${authorkey}`;
        const url = 'https://bookapp-api-function-alysha.azurewebsites.net' + `/api/Errors`;
        return this.genericGet(url);
    }

    async createUser(name, emailAddress) {
        const userinfo = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
                name: name,
                emailAddress: emailAddress
            })
        }
        fetch(process.env.REACT_APP_ENDPOINT + `/api/UserProfiles`, userinfo)
    }
}

//export default apiCall;


//Azure App Service
//fetch('https://bookapp-backend-api-app-service.azurewebsites.net/api/UserProfiles', userinfo)

//Azure Function
//fetch('https://bookapp-api-function-alysha.azurewebsites.net/api/UserProfiles', userinfo)


