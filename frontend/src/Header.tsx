import logo from './BigDealBowling.png';
function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col-4">
        <img
          src={logo}
          className="logo"
          alt="logo"
          style={{ height: '100px' }}
        />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
        <p>Big things</p>
      </div>
    </header>
  );
}

export default Header;
