import React, { Component } from "react";
import { Route } from "react-router-dom";
import { NavLink } from "react-router-dom";
import SignUp from "./SignUp";
import ConektaHome from "./ConektaHome";

class App extends React.Component {
  render() {
    return (
      <div>
        <div className="navBar">
          <NavLink to="/conektahome"> Login </NavLink>
          <NavLink to="/signup" className="navBar">
            Sign up
          </NavLink>
          <Route exact path={"/signUp"} component={SignUp} />
          <Route exact path={"/conektahome"} component={ConektaHome} />
          <Route exact path={""} component={ConektaHome} />
        </div>
        <div />
      </div>
    );
  }
}

export default App;
