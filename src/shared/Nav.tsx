import React from 'react'
import { Link } from 'react-router-dom'

function Nav() {
  return (
    <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
      <div className="container-fluid">
        <Link to="/" className="navbar-brand">Bebop Bank ATM</Link>
        <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
          <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarNav">
          <ul className="navbar-nav">
            <li className="nav-item">
              <Link to="/" className="nav-link">Welcome</Link>
            </li>
            <li className="nav-item">
              <Link to="/mainmenu" className="nav-link">Main Menu</Link>
            </li>
            <li className="nav-item">
              <Link to="/createcustomer" className="nav-link">Create an Account</Link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  )
}

export default Nav