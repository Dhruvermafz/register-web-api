import './App.css';
import Login from './components/Login';
import Registration from './components/Registration';
import { BrowserRouter as Router,
  Route,
  Routes } from 'react-router-dom';

function App() {
  return (
    <Router>
    <div className="App">
      <Routes>
        <Route exact path='/' element={<Registration/>} />
        <Route exact path='/login' element={<Login/>} />
      </Routes>
    </div>
    </Router>
  );
}

export default App;
