import React from 'react';
import './styles.css';

import Button from '../Button';
import EbeLogo from '../../Assets/Logo/logoebevetor1.png'

import { isAuthenticated, logout } from '../../services/auth.js'
import { Link } from 'react-router-dom';

export default function Header() { 
    if (isAuthenticated()) {
        return <header>
            <Link to='/' className='LogoRedirect'><img src={EbeLogo} alt="Logo" className="logo"></img></Link>
            <div className='headerBtns'>
                <Button link='/Perfil' btnName='Perfil' />
                <Button link='/' onClick={logout} btnName='Logout' />
            </div>
        </header>
    } else return <header>
        <Link to='/' className='LogoRedirect'><img src={EbeLogo} alt="Logo" className="logo"></img></Link>
        <div className='headerBtns'>
            <Button link='/SignIn' btnName='Login' />
            <Button link='/SignUp' btnName='Register' />
        </div>
    </header>
}
