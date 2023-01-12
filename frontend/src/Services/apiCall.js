
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

    async genericUpdate(url, body, methodName = 'PUT') {
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

    // Create an Account for New User
    async createUser(name, emailAddress) {
        const userinfo = {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({
                name: name,
                emailAddress: emailAddress
            })
        }
        fetch('https://readmorenovels.azurewebsites.net/api/UserProfiles', userinfo)
    }

    async searchUsers(emailAddress) {
        //const url = process.env.REACT_APP_ENDPOINT + `/api/UserProfiles/email/${emailAddress}`;
        const urlPrefix = process.env.REACT_APP_ENDPOINT;
        console.log(emailAddress);
        console.log(urlPrefix);
        const url = 'https://bookapp-api-function-alysha.azurewebsites.net' + `/api/UserProfiles/email/${emailAddress}`;
        return this.genericGet(url);
    }

    // Verify Existing User Log In
    async loginUser(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/user/login/${x}`;
        return this.genericGet(url);
    }

    // Verify Existing User Log In
    async getUserById(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/user/${x}`;
        return this.genericGet(url);
    }

    // Find Users to Add Users 
    async findUsers(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/UserProfiles/email/${x}`;
        return this.genericGet(url);
    }
  
    // Books 
    async searchBooks(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/Books/${x}`;
        return this.genericGet(url);
    }

    // Book Details of One Book
    async searchBook(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/Books/key/${x}`;
        return this.genericGet(url);
    }

    // My Books
    async getMyBooks(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/user/books/${x}`;
        return this.genericGet(url);
    }

    // My Books
    async updateMyBooks(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/user/books/${x}`;
        return this.genericUpdate(url);
    }

    //Dashboard
    async getFriends(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/user/friends/${x}`;
        return this.genericGet(url);
    }

    //Dashboard
    async updateFriends(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/user/friends/${x}`;
        return this.genericUpdate(url);
    }

    //Dashboard
    async getProgress(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/user/progress/${x}`;
        return this.genericGet(url);
    }

    //Dashboard
    async getRecommendations(x) {
        const url = 'https://readmorenovels.azurewebsites.net' + `/api/user/friends/${x}`;
        return this.genericGet(url);
    }

}

//export default apiCall;


