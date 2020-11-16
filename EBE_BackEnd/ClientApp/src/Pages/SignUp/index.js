import React, { Component } from "react";
import { Link } from "react-router-dom";
import './styles.css'

import Logo from '../../Assets/Logo/logoebevetor1.png'

export default class SignUp extends Component {

    state = {
        Name: "",
        BirthDate: "",
        Email: "",
        Password: "",
    }

    handleSignUp = e => {
        e.preventDefault();
        alert("Registando...");
    };

    render() {
        return (
            <div id='SignUpContainer'>
                <form onSubmit={this.handleSignUp}>
                    <img src={Logo} alt="Even Better Events logo" />
                    {this.state.error && <p>{this.state.error}</p>}
                    <input
                        type="text"
                        placeholder="Nome de usuário"
                        onChange={e => this.setState({ Name: e.target.value })}
                    />
                    <input
                        type="text"
                        placeholder="Data de Nascimento"
                        onChange={e => this.setState({ BirthDate: e.target.value })}
                    />
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
                    <button type="submit">Cadastrar grátis</button>
                    <hr />
                    <Link to="/SignIn" id="SignUpLogin">Já está cadastrado? Então faça login!</Link>
                </form>
            </div>
        )
    }
}