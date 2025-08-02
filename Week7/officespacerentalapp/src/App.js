import React from 'react';

const offices = [
  { name: "Tech Park", rent: 50000, address: "Bangalore" },
  { name: "Startup Hub", rent: 75000, address: "Mumbai" },
  { name: "Work Nest", rent: 45000, address: "Chennai" },
];

function App() {
  return (
    <div style={{ fontFamily: 'Arial, sans-serif', padding: '20px', textAlign: 'center' }}>
      <h1>🏢 Office Space Rental</h1>

      {/* Correctly loading from /public folder */}
      <img
        src="office-bg.jpeg"
        alt="Office Background"
        style={{
          width: "300px",
          height: "300px",
          objectFit: "fill",
          borderRadius: "10px",
          marginBottom: "20px",
          boxShadow: "0 4px 8px rgba(0,0,0,0.1)",
        }}
      />

      <h2>Available Spaces:</h2>

      {offices.map((office, index) => (
        <div
          key={index}
          style={{
            border: "1px solid #ddd",
            padding: "15px",
            margin: "10px auto",
            maxWidth: "400px",
            borderRadius: "10px",
            backgroundColor: "#f9f9f9",
            textAlign: "left"
          }}
        >
          <h3>{office.name}</h3>
          <p>
            Rent:{" "}
            <span style={{ color: office.rent < 60000 ? "red" : "green" }}>
              ₹{office.rent}
            </span>
          </p>
          <p>Address: {office.address}</p>
        </div>
      ))}
    </div>
  );
}

export default App;
