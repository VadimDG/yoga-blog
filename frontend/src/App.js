import React, { Component } from 'react';
import './App.css';

class App extends Component {
  render() {
    return (
      <div className="App">
        <div className="header">
          <div className="userSection">
            <div className="userInfo">
              Logged in user
            </div>
            <div className="actionButtons">
              <button>Loggin</button>
              <button>Sign up</button>
            </div>
          </div>
        </div>
        
      </div>
    );
  }
}

export default App;
