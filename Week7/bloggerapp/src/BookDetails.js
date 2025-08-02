import React from 'react';

function BookDetails() {
  const books = [
    { title: "Master React", price: 670 },
    { title: "Deep Dive into Angular 11", price: 800 },
    { title: "Mongo Essentials", price: 450 },
  ];

  return (
    <div style={{ textAlign: 'left', padding: '10px' }}>
      <h2>Book Details</h2>
      {books.map((book, index) => (
        <div key={index} style={{ marginBottom: '10px' }}>
          <strong>{book.title}</strong><br />
          {book.price}
        </div>
      ))}
    </div>
  );
}

export default BookDetails;
