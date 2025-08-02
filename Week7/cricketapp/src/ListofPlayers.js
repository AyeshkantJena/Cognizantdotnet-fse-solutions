import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: "Virat", score: 90 },
    { name: "Rohit", score: 40 },
    { name: "Rahul", score: 50 },
    { name: "Dhawan", score: 75 },
    { name: "Pant", score: 60 },
    { name: "Hardik", score: 80 },
    { name: "Jadeja", score: 55 },
    { name: "Ashwin", score: 45 },
    { name: "Bumrah", score: 35 },
    { name: "Shami", score: 70 },
    { name: "Siraj", score: 85 }
  ];

  const filteredPlayers = players.filter(p => p.score < 70);

  return (
    <div>
      <h2>All Players</h2>
      {players.map((player, index) => (
        <p key={index}>{player.name}: {player.score}</p>
      ))}

      <h3>Filtered Players (Score &lt; 70)</h3>
      {filteredPlayers.map((player, index) => (
        <p key={index}>{player.name}: {player.score}</p>
      ))}
    </div>
  );
};

export default ListofPlayers;
