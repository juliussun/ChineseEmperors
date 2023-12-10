import { useState, useEffect } from "react";

function CreateEmperor() {
  const [emperor, setEmperor] = useState([]);

  return (
    <div className="">
        <form action="/api/ChineseEmperor/" method="post" className="d-flex flex-column mb-3">
            <input id="nickName" type="text" placeholder="Nick Name" />
            <input id="firstName" type="text" placeholder="First Name" />
            <input id="lastName" type="text" placeholder="Last Name" />
            <input id="eraName" type="text" placeholder="Dynasty" />
            <input id="templeName" type="text" placeholder="Temple Name" />
            <input id="posthumousName" type="text" placeholder="Posthumous Name" />
            <button>Add</button>
        </form>
    </div>
  )

  

  
}

export default CreateEmperor;
