import React, { useEffect } from "react";
import { useState } from "react";
import axios from "axios";

function SignUp() {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [interests, setInterests] = useState("");
  const [skills, setSkills] = useState("");
  //const [data, setData] = useState(response.data);

  useEffect(() => {
    axios.post("api/people").then(response => {
      console.log(response.data);

      // update first name here
      setFirstName(response.data.firstName);
      // update last name here
      setLastName(response.data.lastName);
    });
  });

  return (
    <div>
      <form>
        <label htmlFor="fName">First Name</label>
        <input
          type="text"
          placeholder="First Name"
          value={firstName}
          onChange={e => setFirstName(e.target.value)}
        />
        <label htmlFor="lName">Last Name</label>
        <input
          type="text"
          placeholder="Last name"
          value={lastName}
          onChange={e => setLastName(e.target.value)}
        />
        <label htmlFor="interests">Interests</label>
        <input
          type="textArea"
          placeholder="Interests"
          value={interests}
          onChange={e => setInterests(e.target.value)}
        />
        <label htmlFor="skills">Skills</label>
        <input
          type="textArea"
          placeholder="Skills"
          value={skills}
          onChange={e => setSkills(e.target.value)}
        />
      </form>
    </div>
  );
}
export default SignUp;
