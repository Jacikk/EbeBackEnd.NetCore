import React, { Component } from 'react';
import Layout from './components/Layoult';
import Routes from './routes.js'

export default class App extends Component {
  static displayName = 'Even Better Events';

  render () {
    return (
      <Layout>
        <Routes />
      </Layout>
    );
  }
}
