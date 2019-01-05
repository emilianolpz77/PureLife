import React, { Component } from "react";
import { useState } from "react";
import { Route } from "react-router-dom";
import styles from "./HomeStyles.module.css";

// console.log("styles", styles);

function ConektaHome() {
  return (
    <div className={styles.body}>
      <div className={styles.videoOverlay}>
        <h1>Conekta</h1>
        <h2>Where iron meets iron. You decide if it sharpens or dulls.</h2>
      </div>
      <div>
        <video className={styles.videoBg} autoPlay muted loop>
          <source
            src="http://www.georgewpark.com/video/blurred-street.mp4"
            type="video/mp4"
          />
          <source
            src="http://www.georgewpark.com/video/blurred-street.webm"
            type="video/webm"
          />
        </video>
      </div>
      <div className={styles.footer}>
        <h5>Conekta Inc.</h5>
        <h5>212 Elevate Lane</h5>
        <h5>Los Angeles, CA 90001</h5>

        <h5>(213)837-6200</h5>
        <br />
        <h3 href="emilianolpz77@gmail.com">Drop us a line</h3>
      </div>
    </div>
  );
}
export default ConektaHome;
