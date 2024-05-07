import React from "react"
import "./index.css"
import BoxListItem from "../BoxListItem"

export function BoxList(props) {
  return (
    <article className="containerBox">
      <div className="boxHeader">
        <p className="boxTitle">{props.title}</p>
        <p className="boxCount">({props.data.length} itens encontrados)</p>
      </div>
      <div className="boxBody">
        <ul>
          {(props.title === "Pedidos de Venda" &&
            props.data.length > 0 &&
            props.data.map((dataObject) => (
              <BoxListItem
                key={dataObject.salesOrderID}
                id={dataObject.salesOrderID}
                name={dataObject.materialName}
                quantity={dataObject.quantity}
              />
            ))) ||
            (props.title === "Pedidos de Compra" &&
              props.data.length > 0 &&
              props.data.map((dataObject) => (
                <BoxListItem
                  key={dataObject.purchaseOrderID}
                  id={dataObject.purchaseOrderID}
                  name={dataObject.materialName}
                  quantity={dataObject.quantity}
                />
              ))) ||
            (props.title === "Produtos" &&
              props.data.length > 0 &&
              props.data.map((dataObject) => (
                <BoxListItem
                  key={dataObject.materialID}
                  id={dataObject.materialID}
                  name={dataObject.materialName}
                  quantity={dataObject.quantity}
                />
              ))) ||
            (props.title === "Equipamentos" &&
              props.data.length > 0 &&
              props.data.map((dataObject) => (
                <BoxListItem
                  key={dataObject.equipmentID}
                  id={dataObject.equipmentID}
                  name={dataObject.equipmentName}
                />
              ))) ||
            (props.title === "Mão de Obra" &&
              props.data.length > 0 &&
              props.data.map((dataObject) => (
                <BoxListItem
                  key={dataObject.workforceID}
                  id={dataObject.workforceID}
                  name={dataObject.name}
                />
              ))) ||
            (props.data.length === 0 && (
              <p className="boxCountItem">nenhum item encontrado</p>
            ))}
        </ul>
      </div>
    </article>
  )
}
