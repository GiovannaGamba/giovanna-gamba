import { MagnifyingGlass } from "@phosphor-icons/react"
import "./index.css"
import { useState } from "react"

export function Search(props) {
  const [searchText, setSearchText] = useState("")

  return (
    <header className="containerSearch">
      <input
        className="search"
        onChange={(event) => setSearchText(event.target.value)}
      />
      <button
        className="buttonSearch"
        onClick={() => props.onSearch(searchText)}
      >
        <MagnifyingGlass size={18} />
      </button>
    </header>
  )
}
