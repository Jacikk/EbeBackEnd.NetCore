import React, { Component } from "react";
import { Link } from "react-router-dom";
import './styles.css'

import Logo from '../../Assets/Logo/logoebevetor1.png'

export default class SignUp extends Component {

    state = {
        Email: "",
        Password: "",
    }

    handleSignUp = e => {
        e.preventDefault();
    };

    render() {
        return (
            <div id='SignUpContainer'>
                <form onSubmit={this.handleSignUp}>
                    <img src={Logo} alt="Even Better Events logo" />
                    {this.state.error && <p>{this.state.error}</p>}
                    <input
                        type="email"
                        placeholder="Endereço de e-mail"
                        onChange={e => this.setState({ Email: e.target.value })}
                    />
                    <input
                        type="password"
                        placeholder="Senha"
                        onChange={e => this.setState({ Password: e.target.value })}
                    />
                    <button type="submit">Login</button>
                    <hr />
                    <Link to="/" id="SignUpLogin">Esqueceu a senha?</Link>
                    <hr />
                    <Link to="/SignUp" id="SignUpLogin">Não é registrado ainda? Registre-se!</Link>
                </form>
            </div>
        )
    }
}