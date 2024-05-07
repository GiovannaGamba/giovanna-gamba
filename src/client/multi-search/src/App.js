import React, { useState } from "react"
import "./App.css"
import Logo from "./layout/logo_multisearch.png"
import { Search } from "./components/Search"
import { BoxList } from "./components/BoxList"

export default function App() {
  const [multiSearchData, setMultiSearchData] = useState({
    equipments: [],
    materials: [],
    purchaseOrders: [],
    saleOrders: [],
    workForces: [],
  })

  function searchData(textToSearch) {
    fetch(`https://localhost:7241/main?textToSearch=${textToSearch}`)
      .then((response) => response.json())
      .then((data) => setMultiSearchData(data))
      .catch((error) => console.log("Error fetching data: ", error))
  }

  function getTotalCount() {
    return (
      multiSearchData.equipments.length +
      multiSearchData.materials.length +
      multiSearchData.purchaseOrders.length +
      multiSearchData.saleOrders.length +
      multiSearchData.workForces.length
    )
  }

  return (
    <article className="container">
      <img src={Logo} alt="Logo da MultiSearch" />
      <div className="containerBoxShadow">
        <Search onSearch={searchData} />
        {getTotalCount() > 0 ? (
          <p className="textScope">
            Foram encontrados {getTotalCount()} resultados:
          </p>
        ) : (
          <p className="textScope">Nenhum item para visualizar</p>
        )}
        {getTotalCount() > 0 && (
          <main className="mainBoxList">
            <BoxList
              data={multiSearchData.saleOrders}
              title="Pedidos de Venda"
            />
            <BoxList
              data={multiSearchData.purchaseOrders}
              title="Pedidos de Compra"
            />
            <BoxList data={multiSearchData.materials} title="Produtos" />
            <BoxList data={multiSearchData.equipments} title="Equipamentos" />
            <BoxList data={multiSearchData.workForces} title="Mão de Obra" />
          </main>
        )}
      </div>
    </article>
  )
}
