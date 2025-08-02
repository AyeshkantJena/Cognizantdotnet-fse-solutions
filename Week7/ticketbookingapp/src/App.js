import React, { useState } from 'react';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  return (
    <div>
      <h1>Ticket Booking App</h1>
      <button onClick={() => setIsLoggedIn(!isLoggedIn)}>
        {isLoggedIn ? "Logout" : "Login"}
      </button>
      {isLoggedIn ? <UserPage /> : <GuestPage />}
    </div>
  );
}

function UserPage() {
  return <h2>Welcome User! Book your flights now.</h2>;
}

function GuestPage() {
  return <h2>Hello Guest! Please login to book tickets.</h2>;
}

export default App;
