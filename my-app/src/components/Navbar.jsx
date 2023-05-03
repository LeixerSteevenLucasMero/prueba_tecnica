import React from 'react';
import './Navbar.css';

function Navbar() {
  return (
    <nav className="navbar">
      <div className="navbar-logo">
        <a href="/">Logo</a>
      </div>
      <ul className="navbar-links">
        <li><a href="/">Inicio</a></li>
        <li><a href="/usuarios">Usuarios</a></li>
        <li><a href="/api">API</a></li>
      </ul>
    </nav>
  );
}

export default Navbar;
