import React from 'react'
import './Mainmenu.css'

function Mainmenu() {
  return (
    <form className='mainmenu'>
      <h1>What would you like to do?</h1>
      <div className='container'>
        <button type="button" className="btn btn-primary btn-lg rightmarg">Deposit</button>
        <button type="button" className="btn btn-secondary btn-lg rightmarg">Withdraw</button>          
        <button type="button" className="btn btn-primary btn-lg">Transfer</button>
      </div>

      <div className='container'>
        <button type="button" className="btn btn-primary btn-lg">Exit</button>
      </div>
    </form>
  )
}

export default Mainmenu