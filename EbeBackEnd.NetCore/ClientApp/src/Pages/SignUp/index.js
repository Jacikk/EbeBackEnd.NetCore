import React, { Component } from "react";
import { Link, withRouter } from "react-router-dom";
import './styles.css'

import Api from '../../services/api'
import { login } from "../../services/auth";

import Logo from '../../Assets/Logo/logoebevetor1.png'

class SignUp extends Component {

    state = {
        email: "",
        password: "",
        confirmPassword: "",
        accessLevel: "CommonUser"
    }

    handleSignUp = async e => {
        e.preventDefault();
        const { email, password, confirmPassword, accessLevel } = this.state;
        if (!confirmPassword || !email || !password) {
          this.setState({ error: "Preencha todos os dados para se cadastrar" });
        } else {
          try {
            const response = await Api.post("/auth/Registrar", { email, password, confirmPassword, accessLevel });
            login(response.data.token);
            this.props.history.push("/");
          } catch (err) {
            console.log(err);
            this.setState({ error: "Ocorreu um erro ao registrar sua conta." });
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
                        type="Email"
                        placeholder="Endereço de e-mail"
                        onChange={e => this.setState({ email: e.target.value })}
                    />
                    <input
                        type="Password"
                        placeholder="Senha"
                        onChange={e => this.setState({ password: e.target.value })}
                    />
                    <input
                        type="Password"
                        placeholder="Repita a Senha"
                        onChange={e => this.setState({ confirmPassword: e.target.value })}
                    />
                    <button type="submit">Cadastrar grátis</button>
                    <hr />
                    <Link to="/SignIn" id="SignUpLogin">Já está cadastrado? Então faça login!</Link>
                </form>
            </div>
        )
    }
}

export default withRouter(SignUp);