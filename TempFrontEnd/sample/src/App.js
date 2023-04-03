// import './App.css';
import * as mock from './MockFunctions';
import React, {useState} from 'react';

function App() {
  const [userId, setUserId] = useState(0);
  const [friendId, setFriendId] = useState(0);
  const [goalId, setGoalId] = useState(0);
  const [friends, setFriends] = useState([]);

  

  const NoUser = () => 
  {
    return (
        <button onClick={()=> {var x = mock.loginUser('pconst@gmail.com', 'Petru Constantin'); setUserId(x.UserId);}}>Login User</button>
    )

  };

  const LoggedInUser = () => 
  {
    return (
      <div>
        <p>User Logged In</p>
        <button onClick={()=> {var x = mock.logoutUser(); setUserId(0);}}>Logout User</button>
      </div>
    );
  }

  const GetFriends = () =>
  {
    return(
      <button onClick = {() => {var x = mock.getFriends();setFriends(x);}}>Get Your Friends</button>
    )
  }

  const NoFriend = () =>
  {
    return(
      <button onClick={()=> {var x = mock.addFriend(2); setFriendId(x.UserId);}}>Add Friend</button>
    )
  }


  const FriendAdded = () =>
  {
    return(
      <div>
        <p>Friend Added</p>
        <button onClick={()=> {var x = mock.deleteFriend(2); setFriendId(0);}}>Remove Friend</button>
      </div>
    )
  }
  
  const NoGoal = () =>
  {
    return(
      <button onClick={()=> {var x = mock.addGoal(2, "2/21/23"); setGoalId(1);}}>Add Goal</button>
    )
  }

  const GoalAdded = () =>
  {
    return(
      <div>
        <p>Goal Added</p>
        <button onClick={()=> {var x = mock.deleteGoal(1); setGoalId(0);}}>Remove Goal</button>
      </div>
    )
  }

  return (
    <div>
        <div id = "userLogin">
        {((userId === 0) && <NoUser/>)}
        {((userId != 0) && <LoggedInUser/>)}
      </div>
      <br></br>
        <div id = "FriendAdd">
        {((friendId === 0)&&<NoFriend/>)}
        {((friendId !=0)&&<FriendAdded/>)}
        </div>
      <br></br>
        <div id = "GoalAdd">
        {((goalId === 0)&&<NoGoal/>)}
        {((goalId !=0)&&<GoalAdded/>)}
        </div>
      <div id= "Friends">
        <GetFriends></GetFriends>
        <p>Friends</p>

        {friends.map((friend) => <li>{friend.UserId}</li>)}
      </div>
    </div>
  
  );
}

export default App;
