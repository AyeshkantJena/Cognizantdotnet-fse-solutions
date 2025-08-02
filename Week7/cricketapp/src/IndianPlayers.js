import React from 'react';

const IndianPlayers = () => {
  const T20Players = ['Kohli', 'Rohit', 'Pant', 'Surya'];
  const RanjiPlayers = ['Pujara', 'Iyer', 'Saha'];

  const mergedPlayers = [...T20Players, ...RanjiPlayers];

  const [oddTeam, evenTeam] = [
    mergedPlayers.filter((_, i) => i % 2 !== 0),
    mergedPlayers.filter((_, i) => i % 2 === 0)
  ];

  return (
    <div>
      <h2>Odd Team</h2>
      <ul>{oddTeam.map((p, i) => <li key={i}>{p}</li>)}</ul>
      <h2>Even Team</h2>
      <ul>{evenTeam.map((p, i) => <li key={i}>{p}</li>)}</ul>
    </div>
  );
};

export default IndianPlayers;
