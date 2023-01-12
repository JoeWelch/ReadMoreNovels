import React from 'react';
import '../App.css';
import { apiCall } from '../Services/apiCall';
/*import Card from 'react-bootstrap/Card';
*/
import ListGroup from 'react-bootstrap/ListGroup';
import { Badge, Button, Card, Navbar, Nav, Table, Container, Row, Col, Form, OverlayTrigger, Tooltip, } from "react-bootstrap";



function MyBooks() {
    return (
        <div>
        <Container fluid>
            <p> Welcome to My Books </p>
            <br>
            </br>
            <h5> Currently Reading </h5>
            <br>
            </br>
            <Row>
                <Col xs lg="2">
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="holder.js/100px180?text=Image cap" />
                        <Card.Body>
                            <Card.Title>Card Title</Card.Title>
                            <Card.Text>
                                Some quick example text to build on the card title and make up the
                                bulk of the card's content.
                            </Card.Text>
                        </Card.Body>
                        <ListGroup className="list-group-flush">
                            <ListGroup.Item>Cras justo odio</ListGroup.Item>
                            <ListGroup.Item>Dapibus ac facilisis in</ListGroup.Item>
                            <ListGroup.Item>Vestibulum at eros</ListGroup.Item>
                        </ListGroup>
                        <Card.Body>
                            <Card.Link href="#">Card Link</Card.Link>
                            <Card.Link href="#">Another Link</Card.Link>
                        </Card.Body>
                    </Card>
                </Col>
                <Col xs lg="2">
                    <Card style={{ width: '18rem' }}>
                        <Card.Img variant="top" src="holder.js/100px180?text=Image cap" />
                        <Card.Body>
                            <Card.Title>Card Title</Card.Title>
                            <Card.Text>
                                Some quick example text to build on the card title and make up the
                                bulk of the card's content.
                            </Card.Text>
                        </Card.Body>
                        <ListGroup className="list-group-flush">
                            <ListGroup.Item>Cras justo odio</ListGroup.Item>
                            <ListGroup.Item>Dapibus ac facilisis in</ListGroup.Item>
                            <ListGroup.Item>Vestibulum at eros</ListGroup.Item>
                        </ListGroup>
                        <Card.Body>
                            <Card.Link href="#">Card Link</Card.Link>
                            <Card.Link href="#">Another Link</Card.Link>
                        </Card.Body>
                    </Card>
                </Col>
                <Col xs lg="2">
                <Card style={{ width: '18rem' }}>
                    <Card.Img variant="top" src="holder.js/100px180?text=Image cap" />
                    <Card.Body>
                        <Card.Title>Card Title</Card.Title>
                        <Card.Text>
                            Some quick example text to build on the card title and make up the
                            bulk of the card's content.
                        </Card.Text>
                    </Card.Body>
                    <ListGroup className="list-group-flush">
                        <ListGroup.Item>Cras justo odio</ListGroup.Item>
                        <ListGroup.Item>Dapibus ac facilisis in</ListGroup.Item>
                        <ListGroup.Item>Vestibulum at eros</ListGroup.Item>
                    </ListGroup>
                    <Card.Body>
                        <Card.Link href="#">Card Link</Card.Link>
                        <Card.Link href="#">Another Link</Card.Link>
                    </Card.Body>
                </Card>
                </Col>
            </Row>
            </Container>
        </div>
    );
}

export default MyBooks;

/*
 * 
 * 
 *             <p> Welcome to My Books </p>
            <div>
                <p>
                    Placeholder for My Current Books
{*//*                    make API call to retrieve user's wishlist books with a flag of in progress set to true*//*}
                    Allow to give rating and review
{*//*                    when books render, reviews and ratings should render as well if provided in the api call response, along with buttons that allow them to modify
                    if not available, buttons should be available to allow users to rate and review
                    buttons should link to an api call that sends updated info in a post call to the api*//*}
Allow to mark as read
{*//*                    add a mark as read icon/button -> should send an api post call to the database to update this user's/book's value*//*}
                    Allow to remove from Current Books (should allow user to Add Back to Wishlist to read at a future time or remove entirely)
{*//*                    add button to add back to wishlist
                    add button that say I'm no longer reading this book (not read - just means they put it down and aren't interested anymore)
                    buttons should trigger an API call to update the wishlist and/or the currently reading flag*//*}
</p>
</div>

<div>
<p>
Placeholder for My Wishlist
{*//*                    make API call to retrieve user's wishlist books with in progress flag set to false*//*}
                    Allow to mark as read
{*//*                    add a mark as read icon/button -> should send an api post call to the database to update this user's/book's value*//*}
                    Allow to remove from Wishlist
{*//*                    add button that say I'm no longer reading this book (not read - just means they put it down and aren't interested anymore)
*//*}                </p>
            </div>

            <div>
                <p>
                    Placeholder for My Finished Books
{*//*                    make API to retrieve users books with read flag set to true *//*}
                    Allow to give rating and review
{*//*                    when books render, reviews and ratings should render as well if provided in the api call response, along with buttons that allow them to modify
                    if not available, buttons should be available to allow users to rate and review
                    buttons should link to an api call that sends updated info in a post call to the api*//*}
Allow to mark as unread aka remove from Finished Books
{*//*                    make API call to update read flag to false
*//*}                </p>
            </div>
        </div>

*/