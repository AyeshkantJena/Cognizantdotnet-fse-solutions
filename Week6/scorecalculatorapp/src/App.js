import { CalculateScore } from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore 
        Name="Ayeshkant" 
        School="BJEM School" 
        total={284} 
        goal={3} 
      />
    </div>
  );
}

export default App;
