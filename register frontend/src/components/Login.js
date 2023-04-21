import React from 'react'
import { Link } from 'react-router-dom';
import Registration from './Registration';
function Login () {
  const [uid, getUid] =useState("");
   const [phoneNo, getPhoneNo] = useState("");
    
   const handleUidChange = (value) => {
    getUid(value);
   }

   const handlePhoneChange = (value) => {
    getPhoneNo(value);
   }

   const handleCheck = async () => {
    const data = {
      Uid: uid,
      PhoneNo: phoneNo
    };

    let result = await fetch("",  {
      method: 'get',
      body: JSON.stringify(data),
      headers: {
        'Content-Type': 'application/json'
      },
    });

    result = await result.json();

    if(result){
      alert("login checked")
      get
    }
   }

  
  return (
    <>
      <div className="login-box">
        <h2>Login</h2>
        <form>
          <div className="user-box">
          <label>Id</label>
            <input type="number" placeholder='Enter your ID:' onChange={(e) => handleUidChange(e.target.value)} name='' required="" value={uid} />
           
          </div>
          <div className="user-box">
            <input value={phoneNo} type="number"  name=''  required=""  
        id="txtPhone"
        placeholder="Enter Phone No:"
        onChange={(e) => handlePhoneChange(e.target.value)} />
            <label htmlFor="Password">Password</label>
          </div>
          <div className="button-form">
            
            <a id='submit' href="/login" type='button' onClick={(e) => handleCheck(e.target.value)}>Submit</a>

            <div id="register">
                 Don't have an account? 
                 <Link to={<Registration/>}>
                 <a href="/register">Register</a></Link>
            </div>
          </div>
        </form>
      </div>
    </>
  )
}

export default Login;
