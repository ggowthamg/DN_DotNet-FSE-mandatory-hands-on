import logo from './logo.svg';
import './App.css';
import { CalculateScore } from '../src/Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore Name={"John Doe"}
        School={"DNV High School"}
        total={85}
        goal={100} 
        />
    </div>
  );
}

export default App;
