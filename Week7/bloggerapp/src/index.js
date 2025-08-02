import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);


// import React, { useState } from 'react';

// function App() {
//   const [view, setView] = useState("book");

//   return (
//     <div style={{ padding: '20px' }}>
//       <h1>View Switcher</h1>
//       <button onClick={() => setView("book")}>Book</button>
//       <button onClick={() => setView("blog")}>Blog</button>

//       {view === "book" ? <p>Book View Loaded</p> : <p>Blog View Loaded</p>}
//     </div>
//   );
// }

// export default App;
