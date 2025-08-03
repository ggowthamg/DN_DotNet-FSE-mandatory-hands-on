// EvenPlayers.js
import React from 'react';

function EvenPlayers({ players }) {
  // Get even-indexed players: index 1, 3, 5, ...
  const evenPlayers = players.filter((_, index) => index % 2 !== 0);

  return (
    <ul>
      {evenPlayers.map((player, index) => (
        <li key={index}>{player}</li>
      ))}
    </ul>
  );
}

export default EvenPlayers;
