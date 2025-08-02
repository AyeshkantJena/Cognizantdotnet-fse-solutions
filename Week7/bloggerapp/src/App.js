import React, { useState } from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {
  const [view, setView] = useState("all");

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h1>Blogger App</h1>
      <button onClick={() => setView("course")}>Course</button>{' '}
      <button onClick={() => setView("book")}>Book</button>{' '}
      <button onClick={() => setView("blog")}>Blog</button>{' '}
      <button onClick={() => setView("all")}>All</button>

      <div style={{ marginTop: '30px', display: 'flex', justifyContent: 'space-around' }}>
        {(view === "course" || view === "all") && (
          <div style={{ borderLeft: '3px solid green', paddingLeft: '15px' }}>
            <CourseDetails />
          </div>
        )}
        {(view === "book" || view === "all") && (
          <div style={{ borderLeft: '3px solid green', paddingLeft: '15px' }}>
            <BookDetails />
          </div>
        )}
        {(view === "blog" || view === "all") && (
          <div style={{ borderLeft: '3px solid green', paddingLeft: '15px' }}>
            <BlogDetails />
          </div>
        )}
      </div>
    </div>
  );
}

export default App;
