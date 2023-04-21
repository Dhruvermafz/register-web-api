import React from 'react'
import {Nav, NavLink, Bars, NavMenu} from './NavbarElements'

const Navbar = () => {
  return (
    <>
          <Nav>
            <Bars/>
            <NavMenu>
                <NavLink to='/about' activeStyle>   About  </NavLink>
                <NavLink to='/events' activeStyle> Events</NavLink>
                <NavLink to='/registration' activeStyle> Registration </NavLink>
                <NavLink to='/login' activeStyle > Login </NavLink>
            </NavMenu>
            </Nav>     
    </>
  )
}

export default Navbar
