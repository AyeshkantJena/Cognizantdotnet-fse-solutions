import React, { useState } from 'react';

function App() {
  const [count, setCount] = useState(0);

  const increment = () => {
    setCount(count + 1);
    sayHello();
  };

  const sayHello = () => {
    console.log("Hello! You've clicked increment.");
  };

  const sayWelcome = (msg) => {
    alert(`Welcome Message: ${msg}`);
  };

  const handlePress = (e) => {
    alert("I was clicked");
  };

  return (
    <div>
      <h2>Count: {count}</h2>
      <button onClick={increment}>Increment</button>
      <button onClick={() => setCount(count - 1)}>Decrement</button>
      <br /><br />
      <button onClick={() => sayWelcome("Welcome!")}>Say Welcome</button>
      <br /><br />
      <button onClick={handlePress}>Synthetic Event</button>
      <br /><br />
      <CurrencyConvertor />
    </div>
  );
}

function CurrencyConvertor() {
  const [inr, setInr] = useState('');
  const [euro, setEuro] = useState('');

  const handleConvert = () => {
    const converted = (parseFloat(inr) / 90).toFixed(2);
    setEuro(converted);
  };

  return (
    <div>
      <h3>Currency Converter (INR → EURO)</h3>
      <input type="number" value={inr} onChange={e => setInr(e.target.value)} />
      <button onClick={handleConvert}>Convert</button>
      <p>Euro: {euro}</p>
    </div>
  );
}

export default App;
