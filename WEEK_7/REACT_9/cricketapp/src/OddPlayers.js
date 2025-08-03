// OddPlayers.js
import React from 'react';

function OddPlayers({ players }) {
  // Get odd-indexed players: index 0, 2, 4, ...
  const oddPlayers = players.filter((_, index) => index % 2 === 0);

  return (
    <ul>
      {oddPlayers.map((player, index) => (
        <li key={index}>{player}</li>
      ))}
    </ul>
  );
}

export default OddPlayers;
