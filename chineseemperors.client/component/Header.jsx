import { Link } from "react-router-dom";

function Header() {
  return (
    <header>
      <div>
        <div>Chinese Emperors</div>
        <Link to={"/createemperor"}>
            <h3>Create an Emperor</h3>
        </Link>
      </div>
    </header>
  );
}

export default Header;
