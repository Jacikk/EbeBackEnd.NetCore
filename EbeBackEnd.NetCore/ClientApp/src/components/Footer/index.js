import React from 'react';
import './styles.css';
import { Link } from 'react-router-dom';

import EbeLogo from '../../Assets/Logo/logoebevetor1.png'

export default function Footer() {
    return <footer>
        
        <Link to='/' className='LogoRedirect'><img src={EbeLogo} alt="Logo" className="logo"></img></Link>

    </footer>
}