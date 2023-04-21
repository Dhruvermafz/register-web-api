import { useState } from "react";
import React from "react";
import axios from "axios";
import { Link } from "react-router-dom";
import Login from "./Login";

function Registration() {
  const [name, setName] = useState("");
  const [phoneNo, setPhone] = useState("");
  const [address, setAddress] = useState("");
   const [uid, setUid] = useState("");

  const handleNameChange = (value) => {
    setName(value);
  };

  const handlePhoneChange = (value) => {
    setPhone(value);
  };

  const handleAddressChange = (value) => {
    setAddress(value);
  };

  const handleUidChange = (value) =>{
    setUid(value);
  }

  const handleSave =async () => {
    
    const data = {
      Name: name,
      PhoneNo: phoneNo,
      Address: address,
      Uid: uid,
      IsActive: 1,
    };

    
    let result=await fetch("http://localhost:50810/api/Test/Registration",{
      method:'post',
      body:JSON.stringify(data),
      headers:{
         'Content-Type':'application/json'  
      },

    });
    result=await result.json()
    if(result)
    {
      alert("data save")
      setName("")
      setAddress("")
      setPhone("")
      setUid("")
    }
    else    
    {
      alert("error")
    }
    
  };
  return (
    <>
      <span>Registration</span>
      <br />
      <label>Id</label>
      <input value={uid} type="number" id="uid" placeholder="Enter your uid" onChange={(e) => handleUidChange(e.target.value)}/>
      
      <label>Name</label>
      <input value={name}
        type="text"
        id="txtName"
        placeholder="Enter Name:"
        onChange={(e) => handleNameChange(e.target.value)}
      />
      <br />
      <label>Phone No</label>
      <input value={phoneNo}
        type="text"
        id="txtPhone"
        placeholder="Enter Phone No:"
        onChange={(e) => handlePhoneChange(e.target.value)}
      />
      <br />
      <label>Address</label>
      <input value={address}
        type="text"
        id="txtAddress"
        placeholder="Enter Address:"
        onChange={(e) => handleAddressChange(e.target.value)}
      />
      <br />
      <button id="saveBtn" onClick={(e) => handleSave(e.target.value)}>
        Save
      </button>
      <br/>
      <Link to={<Login/>}>
      <button id="loginChange">Login ?</button>
      </Link>
      
      
    </>
  );
}

export default Registration;
