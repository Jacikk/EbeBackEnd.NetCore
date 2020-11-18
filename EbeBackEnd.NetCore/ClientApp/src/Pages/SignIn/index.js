import React, { Component } from "react";
import { Link, withRouter } from "react-router-dom";
import './styles.css'
import axios from 'axios';

import Logo from '../../Assets/Logo/logoebevetor1.png'
import Api from '../../services/api'

import { login } from "../../services/auth";


class SignIn extends Component {

    state = {
        email: "",
        password: ""
    }

    handleSignIn = async e => {
        e.preventDefault();
        const { email, password } = this.state;
        if (!email || !password) {
            this.setState({ error: "Preencha e-mail e senha para continuar!" });
        } else {
            try {
                const response = await Api.post("/auth/login", { email, password });
                login(response.data.token);
                console.log(response.data.token);
                this.props.history.push("/");
                console.log(response.data.token);
            } catch (err) {
                this.setState({
                    error:
                        "Houve um problema com o login, verifique suas credenciais."
                });
            }
        }
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
                        onChange={e => this.setState({ email: e.target.value })}
                    />
                    <input
                        type="password"
                        placeholder="Senha"
                        onChange={e => this.setState({ password: e.target.value })}
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

export default withRouter(SignIn);