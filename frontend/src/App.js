import React, { Component } from 'react';
import './App.scss';
import { Content } from './components/content-menu/content';

class App extends Component {
  render() {
    return (
      <div className="app">
        <Content />        
      </div>
    );
  }
}

export default App;
