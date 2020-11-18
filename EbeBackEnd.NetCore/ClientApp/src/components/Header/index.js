import React from 'react';
import './styles.css';

import Button from '../Button';
import EbeLogo from '../../Assets/Logo/logoebevetor1.png'

export default function Header() {

    
    return <header>
        <img src={EbeLogo} alt="Logo" className="logo"></img>
        <div className='headerBtns'>
            <Button link='/SignIn' btnName='Login' />
            <Button link='/SignUp' btnName='Register' />
        </div>
    </header>
}