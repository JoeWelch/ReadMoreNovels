export const getHighlightedBooks = () => {
    return [
        {
            "Title": "The Kite Runner",
            "Author": "Salam Khalied",
            "Description": "Sample description for book",
        },
        {
            "Title": "Puddinhead Wilson",
            "Author": "Mark Twain",
            "Description": "Funny book by Mark Twain",
        }
]
};

export const loginUser = (emailAddress, name) => {
    console.log(`Login user called: ${emailAddress}, ${name}`)
    return {
        "UserId" : 1,
        "EmailAddress" : emailAddress,
        "UserName" : name
    }
}

export const logoutUser = () => {
    console.log(`Logout user called`)
    return 1;
}

export const getFriends = (userId) => {
    return [
        {
            "UserId" : 2,
            "EmailAddress" : "testuser1@gmail.com",
            "UserName" : "Test User 1"
        },
        {
            "UserId" : 3,
            "EmailAddress" : "testuser2@gmail.com",
            "UserName" : "Test User 2"
        },
        {
            "UserId" : 4,
            "EmailAddress" : "testuser3@gmail.com",
            "UserName" : "Test User 3"
        }

    ];
}

export const addFriend = (userId) => {
    return {
        "UserId" : 2,
        "EmailAddress" : "testuser1@gmail.com",
        "UserName" : "Test User 1"
    };
}

export const deleteFriend = (userId) => {
    return 1;
}

export const searchBooks = (authorFilter, titleFilter) => {
    return [
        {
            "Title": "The Kite Runner",
            "Author": "Salam Khalied",
            "Description": "Sample description for book",
        },
        {
            "Title": "Puddinhead Wilson",
            "Author": "Mark Twain",
            "Description": "Funny book by Mark Twain",
        }
    ];
}