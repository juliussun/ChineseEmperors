import { useState, useEffect } from "react";

function Canvas() {
  const [emperors, setEmperors] = useState([]);

  useEffect(() => {
    fetch("api/ChineseEmperor")
      .then((response) => response.json())
      .then((data) => setEmperors(data))
      .catch((error) => console.error("Error fetching emperors:", error));
  }, []);

  return (
    <div>
      <h1>Canvas</h1>
      {emperors.map((e) => (
        <div key={e.id}>{e.firstName}</div>
      ))}
    </div>
  );
}

export default Canvas;
